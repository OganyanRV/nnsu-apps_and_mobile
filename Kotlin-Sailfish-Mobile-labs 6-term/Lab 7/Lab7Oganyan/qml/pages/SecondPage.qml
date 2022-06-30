import QtQuick 2.0
import Sailfish.Silica 1.0
import MyVectorString 1.0

Page {
    id: page
    allowedOrientations: Orientation.All
    PageHeader { title: "String list"}

    // To enable PullDownMenu, place our content in a SilicaFlickable
    SilicaFlickable {
        anchors.fill: parent;
        contentHeight: column.height


        // PullDownMenu and PushUpMenu must be declared in SilicaFlickable, SilicaListView or SilicaGridView
        PullDownMenu {
            MenuItem {
                text: qsTr("Перейти к заданию 1?")
                onClicked: pageStack.push(Qt.resolvedUrl("FirstPage.qml"))
            }
        }
        Column {
            id: column
            y: 200
            width: parent.width
            Column {
                spacing: 10
                width: parent.width
                MyVectorString {
                    id: list
                    onChange: {text_list.text = list.tostring()}
                }
                TextField {
                    id: text
                    y: 100
                    anchors.horizontalCenter: parent.horizontalCenter
                }
                Button {
                    anchors.horizontalCenter: parent.horizontalCenter
                    text: "Добавить слово"
                    onClicked: list.push(text.text)
                }
                Button {
                    anchors.horizontalCenter: parent.horizontalCenter
                    text: "Удалить слово"
                    onClicked: list.pop()
                }
                Label {
                    id: text_list
                    wrapMode: Text.WordWrap
                    y: 100
                    width: parent.width
                    anchors.horizontalCenter: parent.horizontalCenter
                }
            }
        }
    }
    }

