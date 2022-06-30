package com.example.lab3oganyan

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.util.Log
import android.widget.CalendarView
import android.widget.TimePicker
import android.widget.Toast

class ex6 : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_ex6)

        val tv = findViewById<TimePicker>(R.id.timePicker)
        tv.setOnTimeChangedListener(TimePicker.OnTimeChangedListener() { view, hour, minute ->
            Toast.makeText(view.context, "Hours = $hour Minutes = $minute", Toast.LENGTH_LONG).show()
            Log.d("Data", "Selected time: Hours = $hour Minutes = $minute")
        })
    }
}