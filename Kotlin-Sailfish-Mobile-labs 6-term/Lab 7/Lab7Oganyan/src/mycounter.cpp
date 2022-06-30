#include "mycounter.h"
#include <QDebug>

MyCounter::MyCounter() : QObject() {
    this->count = 0;
}


Q_INVOKABLE void MyCounter::add() {
    this->count++;
    emit change();
}


Q_INVOKABLE void MyCounter::reset() {
    this->count = 0;
    emit change();
}

Q_INVOKABLE void MyCounter::print() {
    qDebug() << "Current cnt: " << this->getcount();
}


Q_INVOKABLE int MyCounter::getcount() {
   return this->count;
}


Q_INVOKABLE void MyCounter::setcount(int new_cnt) {
    this->count = new_cnt;
     emit change();
}
