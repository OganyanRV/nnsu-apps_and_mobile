package com.example.oganyanlab4

import android.R
import android.app.DatePickerDialog
import android.app.DatePickerDialog.OnDateSetListener
import android.app.TimePickerDialog
import android.app.TimePickerDialog.OnTimeSetListener
import android.os.Bundle
import android.text.Editable
import android.text.format.DateUtils
import android.view.View
import android.widget.EditText
import android.widget.TextView
import androidx.appcompat.app.AlertDialog
import androidx.appcompat.app.AppCompatActivity
import java.util.*

class ex3 : AppCompatActivity() {

    var currentDateTime: TextView? = null
    var dateAndTime: Calendar = Calendar.getInstance()
    @Override
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(com.example.oganyanlab4.R.layout.activity_ex3)
        currentDateTime = findViewById<View>(com.example.oganyanlab4.R.id.date_text) as TextView
        setInitialDateTime()
    }



    // отображаем диалоговое окно для выбора даты
    fun setDate(v: View) {
        DatePickerDialog(
            this, d,
            dateAndTime.get(Calendar.YEAR),
            dateAndTime.get(Calendar.MONTH),
            dateAndTime.get(Calendar.DAY_OF_MONTH)
        )
            .show()
    }

    // отображаем диалоговое окно для выбора времени
    fun setTime(v: View) {
        TimePickerDialog(
            this, t,
            dateAndTime.get(Calendar.HOUR_OF_DAY),
            dateAndTime.get(Calendar.MINUTE), true
        )
            .show()
    }

    // установка начальных даты и времени
    private fun setInitialDateTime() {
        currentDateTime!!.text = DateUtils.formatDateTime(
            this,
            dateAndTime.getTimeInMillis(),
            DateUtils.FORMAT_SHOW_DATE or DateUtils.FORMAT_SHOW_YEAR
                    or DateUtils.FORMAT_SHOW_TIME
        )
    }

    // установка обработчика выбора времени
    var t =
        OnTimeSetListener { view, hourOfDay, minute ->
            dateAndTime.set(Calendar.HOUR_OF_DAY, hourOfDay)
            dateAndTime.set(Calendar.MINUTE, minute)
            val txt: TextView = findViewById<TextView>(com.example.oganyanlab4.R.id.time_text)
            txt.text = (hourOfDay.toString()).plus(":").plus(minute.toString())
            setInitialDateTime()
        }

    // установка обработчика выбора даты
    var d =
        OnDateSetListener { view, year, monthOfYear, dayOfMonth ->
            dateAndTime.set(Calendar.YEAR, year)
            dateAndTime.set(Calendar.MONTH, monthOfYear)
            dateAndTime.set(Calendar.DAY_OF_MONTH, dayOfMonth)
            setInitialDateTime()
        }


    fun Input_time(view: View) {
        setTime(view)
    }

    fun Input_date(view: View) {
        setDate(view)
    }

    fun Input_text(view: View) {
        val alert =
            AlertDialog.Builder(this)

        alert.setTitle("Ввод текста")
        alert.setMessage("Ваше сообщение")

        val input = EditText(this)
        alert.setView(input)

        alert.setPositiveButton(
            "Ok"
        ) { dialog, whichButton ->
            val value: Editable? = input.text
            val txt: TextView = findViewById<TextView>(com.example.oganyanlab4.R.id.txt_text)
            txt.text = value

        }

        alert.setNegativeButton(
            "Cancel"
        ) { dialog, whichButton ->
        }

        alert.show()
    }
}