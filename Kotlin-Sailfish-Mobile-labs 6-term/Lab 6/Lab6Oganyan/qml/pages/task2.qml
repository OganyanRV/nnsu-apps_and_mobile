import QtQuick 2.0
import Sailfish.Silica 1.0

Page {
    id: page

    allowedOrientations: Orientation.All

    SilicaFlickable {
        anchors.fill: parent
        PullDownMenu {
            MenuItem {
                text: qsTr("Перейти к заданию 3?")
                onClicked: pageStack.push(Qt.resolvedUrl("task3.qml"))
           }
        }

        Column {
            id: column
            width: page.width

            PageHeader { title: "Text Animation"}

            Text {
                id: text_view
                //fontSizeMode: 40
                font.pixelSize: 40
                text: "Hello world!"
                color: "blue"
                anchors.horizontalCenter: parent.horizontalCenter
                y:300
                state: "normal"


                states: [
                    State {
                        name: "first"

//                        PropertyChanges {
//                            target: text_view
//                            font.pixelSize: 40
//                        }

                        PropertyChanges {
                            target: text_view
                            color: "blue"
                        }
                        PropertyChanges {
                            target: text_view
                            rotation: 0
                        }

                        PropertyChanges {
                            target: text_view
                            y: 300
                        }

                    },

                    State {
                        name: "second"

//                        PropertyChanges {
//                            target: text_view
//                            font.pixelSize: 80
//                        }

                        PropertyChanges {
                            target: text_view
                            color: "red"
                        }
                        PropertyChanges {
                            target: text_view
                            rotation: 180
                        }

                        PropertyChanges {
                            target: text_view
                            y: 1000
                        }

                    }
                ]

                transitions: [
                    Transition {

//                        PropertyAnimation {
//                            property: font.pixelSize
//                            duration: 1000

//                        }

                        NumberAnimation {
                            property: "y"
                            duration: 1000
                        }
                        RotationAnimation {
                            direction: RotationAnimation.Counterclockwise
                            duration: 1000
                        }
                        ColorAnimation {
                            duration: 1000
                        }
                    }
                ]

                MouseArea {
                    anchors.fill: parent
                    onPressed: text_view.state = (text_view.state == "first") ? "second" : "first"
                    onReleased: text_view.state = (text_view.state == "second") ? "first" : "second"
                }

            }
        }
    }
}
