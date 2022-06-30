#ifndef MYCOUNTER_H
#define MYCOUNTER_H

#include <QObject>

class MyCounter : public QObject
{
    Q_OBJECT
    Q_PROPERTY(int count READ getcount WRITE setcount NOTIFY change)
private:
    int count;
public:
    Q_INVOKABLE MyCounter();
    Q_INVOKABLE void add();
    Q_INVOKABLE void reset();
    Q_INVOKABLE int getcount();
    Q_INVOKABLE void print();
    Q_INVOKABLE void setcount(int new_cnt);
signals:
    void change();
};

#endif // MYCOUNTER_H
