import QtQuick 2.0
import Sailfish.Silica 1.0

Page {
    id: page
    allowedOrientations: Orientation.All
    property var dataModel: [
        {color: "green", textcolor:"white", text: "зеленый"},
        {color: "yellow", textcolor:"white", text: "желтый" },
        {color: "red", textcolor:"black", text: "красный" },
        {color: "orange", textcolor:"black" }
    ]
    SilicaListView {
        PullDownMenu {
            MenuItem {
                text: qsTr("Перейти к заданию 4?")
                onClicked: pageStack.push(Qt.resolvedUrl("task4.qml"))
            }
        }

        anchors.fill: parent
        header: PageHeader { title: "JavaScript Model" }
        model: dataModel
        spacing: 10
        delegate: Rectangle {
            width: parent.width
            height: 100
            color: modelData.color
            Text {
                anchors.centerIn: parent
                text: modelData.text || "empty text"
                color: modelData.textcolor

            }
        }
    }
}
