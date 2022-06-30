import QtQuick 2.0
import Sailfish.Silica 1.0
import  QtQuick.LocalStorage 2.0
Page {
    property var db;
    allowedOrientations: Orientation.All
    PageHeader { title: qsTr("Database") }
    Item {
        id:base
        function createNoteTable() {
            db.transaction(function(tx) {
                tx.executeSql("CREATE TABLE IF NOT EXISTS notes (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,"
                    + "description TEXT NOT NULL);");
            });
        }
        Component.onCompleted: {
            db = LocalStorage.openDatabaseSync("notes", "1.0");
            createNoteTable();
        }
        function insertNote(description) {
            db.transaction(function(tx) {
               tx.executeSql("INSERT INTO notes (description) VALUES(?);", [description]);
            });
        }
        function deleteNote(id) {
            db.transaction(function(tx) {
                tx.executeSql("DELETE FROM notes WHERE id = ?;", [id]);
            });
            //base.selectNotes();
        }
        function retrieveNotes(callback) {
            db.transaction(function(tx) {
                var result = tx.executeSql("SELECT * FROM notes;");
                callback(result.rows);
            });
        }
        function selectNotes() {
                notesListModel.clear();
                base.retrieveNotes(function(notes) {
                    for (var i = 0; i < notes.length; i++) {
                        var note = notes.item(i);
                        notesListModel.append({id: note.id, description: note.description});
                    }
                });
            }
    }
    SilicaListView {

        PullDownMenu {
            MenuItem {
                text: qsTr("Перейти к заданию 7?")
                onClicked: pageStack.push(Qt.resolvedUrl("task7.qml"))
            }
        }

        id:sel
        anchors.fill: parent
        height:parent
        model: ListModel {id: notesListModel }
        delegate: ListItem {
            id: delegate
            Label {
                y:10
                x: 10
                text:description
            }

            MouseArea {
                id:mouse
                anchors.fill: parent
                onClicked: {
                    base.deleteNote(id)
                     base.selectNotes()
                 }
            }

//            menu: ContextMenu {
//                MenuItem {
//                    text: "Delete task"
//                    onClicked: {
//                        base.deleteNote(id)
//                         base.selectNotes()
//                    }
//                }
//            }
        }
    }
    Column{
        id:col
        anchors.bottom:sel.bottom
        TextField {
            id: field
            width: parent.width
        }

        Button{
            id:button
            text:"Add note"
            //width: parent.width
            onClicked:{base.insertNote(field.text);
           base.selectNotes();
            }
        }
    }
    Component.onCompleted:base.selectNotes();
}
