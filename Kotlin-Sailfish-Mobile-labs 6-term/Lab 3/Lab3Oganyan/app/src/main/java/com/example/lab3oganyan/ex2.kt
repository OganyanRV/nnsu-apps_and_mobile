package com.example.lab3oganyan

import android.graphics.Color
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import android.widget.Button
import android.widget.TextView

class ex2 : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_ex2)
    }

    fun click(view: View) {
        val butt = findViewById<Button>(R.id.button2)
        val txt: TextView = findViewById<TextView>(R.id.textViewex2)
        if ( txt.getText().toString() == "Отпущена") {
            txt.setText("Нажата")
            butt.setBackgroundColor(Color.CYAN)
        }
        else {
            txt.setText("Отпущена")
            butt.setBackgroundColor(Color.LTGRAY)
        }

    }
}