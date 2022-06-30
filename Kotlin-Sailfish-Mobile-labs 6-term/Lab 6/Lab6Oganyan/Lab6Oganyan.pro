# NOTICE:
#
# Application name defined in TARGET has a corresponding QML filename.
# If name defined in TARGET is changed, the following needs to be done
# to match new name:
#   - corresponding QML filename must be changed
#   - desktop icon filename must be changed
#   - desktop filename must be changed
#   - icon definition filename in desktop file must be changed
#   - translation filenames have to be changed

# The name of your application
TARGET = Lab6Oganyan

CONFIG += sailfishapp

SOURCES += src/Lab6Oganyan.cpp

DISTFILES += qml/Lab6Oganyan.qml \
    qml/cover/CoverPage.qml \
    qml/pages/Button_my.qml \
    qml/pages/Del.qml \
    qml/pages/RectanglesComp.qml \
    qml/pages/task1.qml \
    qml/pages/task2.qml \
    qml/pages/task3.qml \
    qml/pages/task4.qml \
    qml/pages/task5.qml \
    rpm/Lab6Oganyan.changes.in \
    rpm/Lab6Oganyan.changes.run.in \
    rpm/Lab6Oganyan.spec \
    rpm/Lab6Oganyan.yaml \
    translations/*.ts \
    Lab6Oganyan.desktop

SAILFISHAPP_ICONS = 86x86 108x108 128x128 172x172

# to disable building translations every time, comment out the
# following CONFIG line
CONFIG += sailfishapp_i18n

# German translation is enabled as an example. If you aren't
# planning to localize your app, remember to comment out the
# following TRANSLATIONS line. And also do not forget to
# modify the localized app name in the the .desktop file.
TRANSLATIONS += translations/Lab6Oganyan-de.ts
