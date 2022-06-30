import QtQuick 2.0
import Sailfish.Silica 1.0

Page {
    id: page

    // The effective value will be restricted by ApplicationWindow.allowedOrientations
    allowedOrientations: Orientation.All

    ListModel {
        id: list_model
//        ListElement {count_index: 0}
    }

    Column {
        spacing: Theme.paddingMedium
        //        anchors.margins: Theme.paddingMedium

        width: parent.width
        height: parent.height
id: col
        property int counter: 0

        PageHeader {
            id: header
            title: "Пункт 2"
        }

        Button {
            id: button
            width: parent.width

            anchors.margins: Theme.paddingMedium
            text: "Добавить элемент"
            onClicked:{ list_model.append({count_index: col.counter}); col.counter++;}
        }

        SilicaListView {
            width: parent.width
            height: parent.height - button.height - header.height
            //            y: button.height + 3 * Theme.paddingMedium
            //            x: Theme.paddingMedium
            id: listView
            model: list_model

            delegate: ListItem {
                id: delegate

                onClicked: {console.log(model.index); list_model.remove(model.index);}

                Rectangle {
                    anchors.fill: parent
                    anchors.margins: Theme.paddingSmall

                    Label {
                        anchors.margins: Theme.paddingMedium
                        anchors.centerIn: parent
                        horizontalAlignment: "AlignHCenter"
                        text: "Элемент" + ' ' + model.count_index
                        color: "black"
                    }
                }
            }
            VerticalScrollDecorator {}
        }
    }
}
