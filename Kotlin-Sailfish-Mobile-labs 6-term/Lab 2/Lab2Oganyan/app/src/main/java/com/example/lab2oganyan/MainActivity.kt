package com.example.lab2oganyan

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.util.Log
import android.widget.Button
import android.widget.TextView

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        val Butt: Button = findViewById(R.id.sum)
        Butt.setOnClickListener {
            val t1 = findViewById<TextView>(R.id.first_num)
            val t2 = findViewById<TextView>(R.id.second_num)
            if (t1.getText().toString() != "" && t2.getText().toString() != "") {
                val sum1 = t1.getText().toString().toInt()
                val sum2 = t2.getText().toString().toInt()
                Log.d("Result", (sum1 + sum2).toString())
            }
        }
    }
}