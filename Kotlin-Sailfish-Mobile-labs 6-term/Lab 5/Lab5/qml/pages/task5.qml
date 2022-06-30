import QtQuick 2.0
import QtQuick.XmlListModel 2.0
import Sailfish.Silica 1.0


Page {

    function loadNews() {
        var xhr = new XMLHttpRequest();
        xhr.open('GET', 'http://www.cbr.ru/scripts/XML_daily_eng.asp', true);
        //xhr.open('GET', 'http://www.cbr.ru/scripts/XML_daily.asp', true);
        xhr.onreadystatechange = function() {
            if (xhr.readyState === XMLHttpRequest.DONE) {
               // xmlListModel.xml = xhr.responseText;  кодировка умерла
                xmlListModel.xml = xhr.responseText.replace("windows-1251, utf-8");
            }
        }
        xhr.send();
    }

    id: page;
    allowedOrientations: Orientation.All

    XmlListModel {
        id: xmlListModel
//        source: "http://www.cbr.ru/scripts/XML_daily.asp"
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
                 text: qsTr("Перейти к заданию 6?")
                 onClicked: pageStack.push(Qt.resolvedUrl("task6.qml"))
             }
         }

        anchors.fill: parent
        header: PageHeader { title: "XMLHttpRequest" }
        model: xmlListModel
        delegate: Column {
             x: 10;
             width: parent.width - 2 * x
            Label {
                width: parent.width
                wrapMode: Text.WordWrap
                text: Name + "\n" + Value;
            }
        }
    }
     Component.onCompleted: loadNews();
}




