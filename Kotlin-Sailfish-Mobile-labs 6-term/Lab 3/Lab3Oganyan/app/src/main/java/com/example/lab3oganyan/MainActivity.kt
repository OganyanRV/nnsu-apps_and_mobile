package com.example.lab3oganyan

import android.content.Intent
import android.os.Bundle
import android.view.View
import androidx.appcompat.app.AppCompatActivity


class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
    }

    fun click1(view: View) {
        val intent = Intent(this, ex1::class.java)
        startActivity(intent)
    }

    fun click2(view: View) {
        val intent = Intent(this, ex2::class.java)
        startActivity(intent)
    }

    fun click3(view: View) {
        val intent = Intent(this, ex3::class.java)
        startActivity(intent)
    }

    fun click4(view: View) {
        val intent = Intent(this, ex4::class.java)
        startActivity(intent)
    }

    fun click5(view: View) {
        val intent = Intent(this, ex5::class.java)
        startActivity(intent)
    }

    fun click6(view: View) {
        val intent = Intent(this, ex6::class.java)
        startActivity(intent)
    }

    fun click7(view: View) {
        val intent = Intent(this, ex7::class.java)
        startActivity(intent)
    }

    fun click8(view: View) {
        val intent = Intent(this, ex8::class.java)
        startActivity(intent)
    }

    fun click9(view: View) {
        val intent = Intent(this, ex9::class.java)
        startActivity(intent)
    }
}