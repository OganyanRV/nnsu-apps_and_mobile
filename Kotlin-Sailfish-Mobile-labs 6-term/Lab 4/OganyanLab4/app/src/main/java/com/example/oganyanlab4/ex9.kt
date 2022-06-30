package com.example.oganyanlab4

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import android.widget.TextView

class ex9 : AppCompatActivity() {
    lateinit var count: TextView
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_ex9)
        count = findViewById<TextView>(R.id.count)
    }

    fun click1(view: View) {
        count.text = (count.text.toString().toInt() + 1).toString()
    }
    fun click2(view: View) {
        count.text = (0).toString()
    }
}