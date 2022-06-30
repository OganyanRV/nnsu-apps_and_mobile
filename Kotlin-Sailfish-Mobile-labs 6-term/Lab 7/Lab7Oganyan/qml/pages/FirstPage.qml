import QtQuick 2.0
import Sailfish.Silica 1.0
import MyCounter 1.0

Page {
    id: page
    allowedOrientations: Orientation.All
    PageHeader { title: "Counter"}

    SilicaFlickable {
        anchors.fill: parent;
        contentHeight: column.height

        PullDownMenu {
            MenuItem {
                text: qsTr("Перейти к заданию 2?")
                onClicked: pageStack.push(Qt.resolvedUrl("SecondPage.qml"))
            }
        }
        Column {
            id: column
            y: 200
            width: parent.width
            Column {
                spacing: 10
                width: parent.width
                MyCounter {
                    id: counter
                    count: 0
                    onChange: {text.text = counter.getcount()}
                }
                Label {
                    id: text
                    y: 100
                    text: counter.getcount()
                    font.pixelSize: 80
                    anchors.horizontalCenter: parent.horizontalCenter
                }
                Button {
                    anchors.horizontalCenter: parent.horizontalCenter
                    text: "Увеличить"
                    onClicked: counter.add()
                }
                Button {
                    anchors.horizontalCenter: parent.horizontalCenter
                    text: "Сбросить"
                    onClicked: counter.reset()
                }
            }
        }
    }
}

