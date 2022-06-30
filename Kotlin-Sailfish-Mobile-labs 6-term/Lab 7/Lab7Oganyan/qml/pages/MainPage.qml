import QtQuick 2.0
import Sailfish.Silica 1.0

Page {
    id: page;
    allowedOrientations: Orientation.All;

    SilicaFlickable {
        anchors.fill: parent;
        Column{
            id:col
            //anchors.bottom:sel.bottom
            width: parent.width

            Button {
                id: task_Button_1
                anchors.horizontalCenter: parent.horizontalCenter
                text: "Задание 1"
                onClicked: pageStack.push(Qt.resolvedUrl("FirstPage.qml"))
            }

            Button {
                id: task_Button_2
                anchors.horizontalCenter: parent.horizontalCenter
                text: "Задание 2"
                onClicked: pageStack.push(Qt.resolvedUrl("SecondPage.qml"))
            }

        }
    }
}
