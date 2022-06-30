#include "myvectorstring.h"

Q_INVOKABLE void MyVectorString::push(QString str){
    if (str == "") return;
    str = str.toLower();
    this->list.push_back(str);
    emit change();
}


Q_INVOKABLE void MyVectorString::pop(){
    if (this->list.empty()) return;
    this->list.pop_back();
    emit change();
}


Q_INVOKABLE QString MyVectorString::tostring() {
    QString res = "";
    if(this->list.empty()) return res;
    for(int i = 0; i < this->list.count() - 1; i++) {
        res += this->list[i];
        res += ", ";
    }
    res += this->list[this->list.count() - 1];
    return res;
}
