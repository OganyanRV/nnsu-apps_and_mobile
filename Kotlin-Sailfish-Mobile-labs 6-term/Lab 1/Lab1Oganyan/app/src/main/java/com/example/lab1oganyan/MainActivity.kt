package com.example.lab1oganyan

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import android.widget.TextView

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
    }
    fun onclick(view: View) {
        val text = findViewById<TextView>(R.id.textView)
        val count = findViewById<TextView>(R.id.textView).getText().toString().toInt()
        val cnt2 = count+1
        text.setText(cnt2.toString())
    }
}