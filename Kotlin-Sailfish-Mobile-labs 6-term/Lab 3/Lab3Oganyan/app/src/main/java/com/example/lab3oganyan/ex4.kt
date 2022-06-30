package com.example.lab3oganyan

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import android.widget.TextView

class ex4 : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_ex4)
        val butt = findViewById<Button>(R.id.buttonex4)
        val txt: TextView = findViewById<TextView>(R.id.textView2)
        butt.setOnClickListener {
            val cnt:Int = txt.getText().toString().toInt() + 1
            txt.setText(cnt.toString())
        }
    }


}