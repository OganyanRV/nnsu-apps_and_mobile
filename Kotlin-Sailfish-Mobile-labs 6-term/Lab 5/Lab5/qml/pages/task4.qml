import QtQuick 2.0
import QtQuick.XmlListModel 2.0
import Sailfish.Silica 1.0


Page {
    id: page;
    allowedOrientations: Orientation.All

    XmlListModel {
        id: xmlListModel
        source: "http://www.cbr.ru/scripts/XML_daily.asp"
        query: "/ValCurs/Valute"
//        XmlRole { name: "Numcode"; query: "Numcode/string()";}
//        XmlRole { name: "Charcode"; query: "Charcode/string()";}
//        XmlRole { name: "Nominal"; query: "Nominal/string()";}
        XmlRole { name: "Name"; query: "Name/string()";}
        XmlRole { name: "Value"; query: "Value/string()";}
    }
    SilicaListView {
        PullDownMenu {
            MenuItem {
                text: qsTr("Перейти к заданию 5?")
                onClicked: pageStack.push(Qt.resolvedUrl("task5.qml"))
            }
        }

        anchors.fill: parent
        header: PageHeader { title: "XmlListModel" }
        model: xmlListModel
        delegate: Column {
             width: parent.width
            x: Theme.horizontalPageMargin
            Label {
                text: Name + "\n" + Value; }
        }
    }
}

