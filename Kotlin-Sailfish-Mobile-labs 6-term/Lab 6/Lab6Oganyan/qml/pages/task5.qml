import QtQuick 2.0
import Sailfish.Silica 1.0

Page {
    id: page;
    property int prev_count: 1
    property int added: 0
    property int deleted: 0
    SilicaFlickable {


        anchors.fill: parent
        PageHeader { title: "PageStack"}

        PullDownMenu {
            MenuItem {
                text: qsTr("Перейти к заданию 1?")
                onClicked: pageStack.push(Qt.resolvedUrl("task1.qml"))
            }
        }

        Column {
            y:500
            id: column
            width: page.width
            Button {
                y:200
                id: button1
                text: "Add"
                onClicked: pageStack.pushAttached(Qt.resolvedUrl("Del.qml"))

                color:"green"
            }

            Label {
                y:200
                text: "Added " + page.added
                id: add
            }

            Label {
                y:200
                text: "Deleted " + page.deleted
                id: del
            }
        }

        Component.onCompleted: pageStack.onDepthChanged.connect(upd)


        function upd() {
            console.log(depth + ' ' + page.prev_count)
            if (pageStack.depth - page.prev_count > 0) {
                added++;
            }
            if (pageStack.depth - page.prev_count < 0) {
                deleted++;
            }
            prev_count = pageStack.depth;
            add.text = "Added " + page.added;
            del.text = "Deleted " + page.deleted;
        }
    }
}

