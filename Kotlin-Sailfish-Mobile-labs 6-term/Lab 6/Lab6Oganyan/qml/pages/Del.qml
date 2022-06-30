import QtQuick 2.0
import Sailfish.Silica 1.0


Page {
    Button {
        y:500
        id: button2
        text: "Delete"
        color:"red";
        onClicked: pageStack.popAttached()
    }
}
