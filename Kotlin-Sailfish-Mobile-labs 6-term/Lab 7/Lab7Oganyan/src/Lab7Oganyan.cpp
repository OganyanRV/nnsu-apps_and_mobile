#ifdef QT_QML_DEBUG
#include <QtQuick>
#include <sailfishapp.h>
#include "mycounter.h"
#include "myvectorstring.h"
#endif


int main(int argc, char *argv[])
{
    qmlRegisterType<MyCounter>("MyCounter", 1, 0, "MyCounter");
    qmlRegisterType<MyVectorString>("MyVectorString", 1, 0, "MyVectorString");


    const QMetaObject meta = MyCounter::staticMetaObject;
    QObject *obj = meta.newInstance();
    QObject::connect(obj, SIGNAL(change()), obj, SLOT(print()));
    meta.invokeMethod(obj, "add");
    meta.invokeMethod(obj, "add");
    meta.invokeMethod(obj, "add");
    meta.invokeMethod(obj, "add");
    meta.invokeMethod(obj, "add");
    meta.invokeMethod(obj, "add");
    meta.invokeMethod(obj, "reset");
    meta.invokeMethod(obj, "setcount", Q_ARG(int, 141));
    meta.invokeMethod(obj, "reset");



    return SailfishApp::main(argc, argv);
}
