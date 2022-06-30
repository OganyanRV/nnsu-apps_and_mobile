import QtQuick 2.0
import Sailfish.Silica 1.0

Page {
    id: page

    allowedOrientations: Orientation.All

    SilicaFlickable {
        anchors.fill: parent
        PullDownMenu {
            MenuItem {
                text: qsTr("Перейти к заданию 5?")
                onClicked: pageStack.push(Qt.resolvedUrl("task5.qml"))
            }
        }
        Column {
            id: column
            width: page.width

            PageHeader { title: "Clock"}

            Text {
                id: info
                text: "Clock is not started"
                font.pixelSize: 30
                anchors.horizontalCenter: parent.horizontalCenter
                color: "white"
            }

            Timer {
                id: timer
                interval: 1
                repeat: true
                property var mili_sec: 0

                onTriggered: time.text = time_forward(++mili_sec);
            }

            Text {
                anchors.horizontalCenter: parent.horizontalCenter
                color: "white"
                id: time
                text: time_forward(timer.mili_sec)
                font.pixelSize: 50

            }

            Button {
                id: button
                backgroundColor: "red"
                color: "white"
                anchors.horizontalCenter: parent.horizontalCenter
                text: timer.running ? "Pause" : "Resume"

                onClicked: {
                    timer.running ? timer.stop() : timer.start();
                    info.text = "Clock is started"
                }
            }
        }
    }

    function time_forward(mili_sec) {
        var hh = Math.floor(mili_sec / 360000);
        var mm = Math.floor((mili_sec % 360000) / 6000);
        var ss = Math.floor(((mili_sec % 360000) % 6000) /100);
        var ms = ((mili_sec % 360000) % 6000) % 100;

        hh = hh + '';
        mm = mm + '';
        ss = ss + '';
        ms = ms + '';
        return hh + ":" + mm + ":" + ss + ':' + ms;
    }


}
