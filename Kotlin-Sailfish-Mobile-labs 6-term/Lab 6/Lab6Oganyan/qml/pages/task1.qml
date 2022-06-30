import QtQuick 2.0
import Sailfish.Silica 1.0

Page {

    id: page

    // The effective value will be restricted by ApplicationWindow.allowedOrientations
    allowedOrientations: Orientation.All
    PageHeader { title: "Traffic Light"}

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
        RectanglesComp{}


    }
}
