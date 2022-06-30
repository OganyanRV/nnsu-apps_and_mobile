package com.example.lab3oganyan

import android.os.Bundle
import android.util.Log
import android.widget.Button
import android.widget.CalendarView
import android.widget.CalendarView.OnDateChangeListener
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import java.text.DateFormat
import java.util.*


class ex5 : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_ex5)


        val cv = findViewById<CalendarView>(R.id.calendarView)
        cv.setOnDateChangeListener(OnDateChangeListener { view, year, month, dayOfMonth ->
            Toast.makeText(view.context, "Year=$year Month=$month Day=$dayOfMonth", Toast.LENGTH_LONG).show()
            Log.d("Data", "Selected date: Year=$year Month=$month Day=$dayOfMonth")
        })

    }


}