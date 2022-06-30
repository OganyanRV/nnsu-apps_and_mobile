import QtQuick 2.0
import Sailfish.Silica 1.0


Column {
    width: parent.width
    id: rect_col
    y:300

    Rectangle {
        id: red_light
        color: "black"
        x: parent.width/2 - radius
        width: 200
        height: 200
        radius: 100
    }

    Rectangle {
        id: yellow_light
        color: "black"
        x: parent.width/2 - radius
        width: 200
        height: 200
        radius: 100
    }

    Rectangle {
        id: green_light
        color: "black"
        x: parent.width/2 - radius
        width: 200
        height: 200
        radius: 100
    }

    Image {
        x:30
        id: image
        source: "chicken.png"
    }


    SequentialAnimation {

        running: true
        loops: Animation.Infinite

        ParallelAnimation {
            PropertyAnimation {
                target: yellow_light;
                property: "color";
                to: "black";
                duration: 0
            }

            PropertyAnimation {
                target: red_light;
                property: "color";
                to: "red";
                duration: 0
            }

        }
        PauseAnimation {
            duration: 2000
        }


        ParallelAnimation {
            PropertyAnimation {
                target: red_light;
                property: "color";
                to: "red";
            }

            PropertyAnimation {
                target: yellow_light;
                property: "color";
                to: "yellow";
            }

        }
        PauseAnimation {
            duration: 2000
        }

        ParallelAnimation {

            PropertyAnimation {
                target: red_light;
                property: "color";
                to: "black";
                duration: 0
            }

            PropertyAnimation {
                target: yellow_light;
                property: "color";
                to: "black";
                duration: 0
            }

            PropertyAnimation {
                target: green_light;
                property: "color";
                to: "green";
                duration: 0
            }

        }

        NumberAnimation {
            target: image
            property: "x"
            to: parent.width - 60
            duration: 2000
        }

        ParallelAnimation {
            PropertyAnimation {
                target: green_light;
                property: "color";
                to: "black";
                duration: 0
            }

            PropertyAnimation {
                target: yellow_light;
                property: "color";
                to: "yellow";
                duration: 0
            }

        }

        PauseAnimation {
            duration: 2000
        }

        ParallelAnimation {
            PropertyAnimation {
                target: yellow_light;
                property: "color";
                to: "black";
                duration: 0
            }

            PropertyAnimation {
                target: red_light;
                property: "color";
                to: "red";
                duration: 0
            }

        }
        PauseAnimation {
            duration: 2000
        }


        ParallelAnimation {
            PropertyAnimation {
                target: yellow_light;
                property: "color";
                to: "yellow";
                duration: 0
            }

            PropertyAnimation {
                target: red_light;
                property: "color";
                to: "red";
                duration: 0
            }

        }
        PauseAnimation {
            duration: 2000
        }

        ParallelAnimation {

            PropertyAnimation {
                target: red_light;
                property: "color";
                to: "black";
                duration: 0
            }

            PropertyAnimation {
                target: yellow_light;
                property: "color";
                to: "black";
                duration: 0
            }

            PropertyAnimation {
                target: green_light;
                property: "color";
                to: "green";
                duration: 0
            }

        }

        NumberAnimation {
            target: image
            property: "x"
            to: 30
            duration: 2000
        }

        ParallelAnimation {
            PropertyAnimation {
                target: green_light;
                property: "color";
                to: "black";
                duration: 0
            }

            PropertyAnimation {
                target: yellow_light;
                property: "color";
                to: "yellow";
                duration: 0
            }

        }

        PauseAnimation {
            duration: 2000
        }


    }
}
