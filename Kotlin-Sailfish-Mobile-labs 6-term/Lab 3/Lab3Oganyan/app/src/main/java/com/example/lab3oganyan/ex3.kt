package com.example.lab3oganyan

import android.annotation.SuppressLint
import android.graphics.Color
import android.os.Bundle
import android.view.MotionEvent
import android.view.View.OnTouchListener
import android.widget.Button
import android.widget.TextView
import androidx.appcompat.app.AppCompatActivity


class ex3 : AppCompatActivity() {
    @SuppressLint("ClickableViewAccessibility")
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_ex3)
        val butt = findViewById<Button>(R.id.buttonex3)
        val txt: TextView = findViewById<TextView>(R.id.textViewex3)
        butt.setOnTouchListener(OnTouchListener { v, event ->
            if (event.action == MotionEvent.ACTION_DOWN) {
                txt.setText("Нажата")
                butt.setBackgroundColor(Color.CYAN)
            }
            else if (event.action == MotionEvent.ACTION_UP) {
                txt.setText("Отпущена")
                butt.setBackgroundColor(Color.LTGRAY)
            }
            false
        })
    }


}