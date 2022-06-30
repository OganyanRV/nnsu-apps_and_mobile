import QtQuick 2.0
import Sailfish.Silica 1.0
import Nemo.Configuration 1.0
Page {
    id:page
    allowedOrientations: Orientation.All;

    ConfigurationValue {
        id: setting_text
        key: "/apps/app_name/setting_name"
        defaultValue: "Default"
    }
    ConfigurationValue {
        id: setting_flag
        key: "/apps/app_name/setting_name"
        defaultValue: false
    }

    Column {
        SilicaListView {
            width: parent.width;
            height: 80;
            PullDownMenu {
                MenuItem {
                    text: qsTr("Перейти к заданию 8?")
                    onClicked: pageStack.push(Qt.resolvedUrl("task8.qml"))
                }
            }
        }
        width: parent.width
        PageHeader { title: "ConfigurationValue" }
        TextSwitch {
            id:switch_cv
            text: "flag"
        }
        TextField{
            id:text_cv
            width: parent.width
        }

        Button {
            width: parent.width
            text: "Do"
            onClicked: {
                setting_text.value = text_cv.text
                setting_flag.value = switch_cv.checked
                label_cv.text = "Saved " + setting_text.value + " , " + setting_flag.value + "  into /apps/app_name/setting_name"
            }
        }

        Label{
            width: parent.width
            y: parent.height + 50
            wrapMode: Text.WordWrap
            id:label_cv
            text: "";
        }
    }


}
