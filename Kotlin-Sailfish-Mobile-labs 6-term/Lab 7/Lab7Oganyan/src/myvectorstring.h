#ifndef MYVECTORSTRING_H
#define MYVECTORSTRING_H

#include <QObject>
#include <QVector>



class MyVectorString: public QObject
{
    Q_OBJECT
private:
    QVector<QString> list;
public:
    Q_INVOKABLE void pop();
    Q_INVOKABLE void push(QString str);
    Q_INVOKABLE QString tostring();
signals:
    void change();

};

#endif // MYVECTORSTRING_H
