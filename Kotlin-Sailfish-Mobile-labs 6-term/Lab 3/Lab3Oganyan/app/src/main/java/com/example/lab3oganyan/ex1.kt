package com.example.lab3oganyan

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View

class ex1 : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_ex1)
    }

    fun clickback(view: View) {
        val intent = Intent(this, MainActivity::class.java)
        startActivity(intent)
    }
}