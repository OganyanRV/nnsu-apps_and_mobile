import QtQuick 2.0
import Sailfish.Silica 1.0

Page {  

    id: page

    // The effective value will be restricted by ApplicationWindow.allowedOrientations
    allowedOrientations: Orientation.All

    // To enable PullDownMenu, place our content in a SilicaFlickable
    SilicaFlickable {
        anchors.fill: parent;

        // PullDownMenu and PushUpMenu must be declared in SilicaFlickable, SilicaListView or SilicaGridView
        PullDownMenu {
            MenuItem {
                text: qsTr("Перейти к заданию 2?")
                onClicked: pageStack.push(Qt.resolvedUrl("task2.qml"))
            }
        }

        ListModel {
            id: colorsModel
            ListElement { color: "white"; textcolor:"black"; text: "белый" }
            ListElement { color: "black"; textcolor:"white"; text: "черный" }
            ListElement { color: "blue";  textcolor:"red";  text: "синий" }
        }

        SilicaListView {
            anchors.fill: parent
            width: parent.width
            spacing: Theme.paddingMedium

            header: PageHeader { title: "ListModel" }
            model: colorsModel
            delegate: Rectangle {
                width: parent.width
                height: 100
                color: model.color
                Text {
                    anchors.centerIn: parent
                    text: model.text
                    color: model.textcolor
                }
            }
        }
    }
}
