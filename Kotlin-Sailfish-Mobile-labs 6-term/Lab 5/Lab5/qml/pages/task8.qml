import QtQuick 2.0
import Sailfish.Silica 1.0
import Nemo.Configuration 1.0
Page {
    id:page
    allowedOrientations: Orientation.All;

    ConfigurationGroup {
        id: settings
        path: "/apps/app_name/settings"
        property string text: ""
        property bool flag: false
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
        PageHeader { title: "ConfigurationGroup" }
        TextSwitch {
            id:switch_cg
            text: "flag"
        }
        TextField{
            id:text_cg
            width: parent.width
        }

        Button {
            width: parent.width
            text: "Do"
            onClicked: {
                settings.text = text_cg.text
                settings.flag = switch_cg.checked
                label_cg.text = "Saved " + settings.text + " , " + settings.flag + "  into /apps/app_name/setting_name"
            }
        }

        Label{
            width: parent.width
            y: parent.height + 50
            wrapMode: Text.WordWrap
            id:label_cg
            text: "";
        }
    }


}
