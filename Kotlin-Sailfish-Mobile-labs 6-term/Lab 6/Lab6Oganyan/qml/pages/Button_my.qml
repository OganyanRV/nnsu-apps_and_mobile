import QtQuick 2.0
import Sailfish.Silica 1.0
Item {

    default property var obj
    property alias color: button.color
    Button {
        id: button
        text: obj.text

    }

}
