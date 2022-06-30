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
            onClicked: pageStack.push(Qt.resolvedUrl("task1.qml"))
        }

        Button {
            id: task_Button_2
            anchors.horizontalCenter: parent.horizontalCenter
            text: "Задание 2"
            onClicked: pageStack.push(Qt.resolvedUrl("task2.qml"))
        }

        Button {
            id: task_Button_3
            anchors.horizontalCenter: parent.horizontalCenter
            text: "Задание 3"
            onClicked: pageStack.push(Qt.resolvedUrl("task3.qml"))
        }

        Button {
            id: task_Button_4
            anchors.horizontalCenter: parent.horizontalCenter
            text: "Задание 4"
            onClicked: pageStack.push(Qt.resolvedUrl("task4.qml"))
        }

        Button {
            id: task_Button_5
            anchors.horizontalCenter: parent.horizontalCenter
            text: "Задание 5"
            onClicked: pageStack.push(Qt.resolvedUrl("task5.qml"))
        }

        Button {
            id: task_Button_6
            anchors.horizontalCenter: parent.horizontalCenter
            text: "Задание 6"
            onClicked: pageStack.push(Qt.resolvedUrl("task6.qml"))
        }

        Button {
            id: task_Button_7
            anchors.horizontalCenter: parent.horizontalCenter
            text: "Задание 7"
            onClicked: pageStack.push(Qt.resolvedUrl("task7.qml"))
        }

        Button {
            id: task_Button_8
            anchors.horizontalCenter: parent.horizontalCenter
            text: "Задание 8"
            onClicked: pageStack.push(Qt.resolvedUrl("task8.qml"))
        }
      }

//        SilicaListView {
//            anchors.fill: parent
//            header: PageHeader { title: "List model" }
//            model: dataModel
//            delegate: Rectangle {
//                width: parent.width
//                height: 100
//                color: model.color
//                Text {
//                    anchors.centerIn: parent
//                    text: model.text
//                    color: model.textcolor
//                }
//            }
//        }
    }
}
