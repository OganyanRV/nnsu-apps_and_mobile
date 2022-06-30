import QtQuick 2.0
import Sailfish.Silica 1.0

Page {
    id: page

    allowedOrientations: Orientation.All

    SilicaFlickable {
        anchors.fill: parent
        PullDownMenu {
            MenuItem {
                text: qsTr("Перейти к заданию 4?")
                onClicked: pageStack.push(Qt.resolvedUrl("task4.qml"))
            }
        }

        Column {
            id: column
            width: page.width

            PageHeader { title: "Button"}

            Button_my{
                width: parent.width
                y: 100
                x: column.width/2 - 30
                Text {text: "Hi!"}
                color: "red"
                anchors.horizontalCenter: column.horizontalCenter
            }


        }
    }
}
