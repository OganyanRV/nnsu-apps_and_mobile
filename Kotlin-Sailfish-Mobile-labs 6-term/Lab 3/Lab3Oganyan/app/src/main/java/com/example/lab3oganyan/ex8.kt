package com.example.lab3oganyan

import android.graphics.Color
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Switch
import android.widget.TextView
import res.*
class ex8 : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_ex8)

        val standardSwitch: Switch = findViewById(R.id.switch1)

        standardSwitch.setOnCheckedChangeListener { buttonView, isChecked ->
            val txt: TextView = findViewById(R.id.textView5)
            if(isChecked){
                txt.text = "Преподаватель\n доволен"
                txt.setTextColor(Color.GREEN)
            }else{
                txt.text ="Преподаватель\n не доволен"
                txt.setTextColor(Color.RED)
            }
        }
    }



}