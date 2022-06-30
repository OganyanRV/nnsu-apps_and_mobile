package com.example.lab3oganyan

import android.os.Bundle
import android.util.Log
import android.view.View
import android.widget.AdapterView
import android.widget.AdapterView.OnItemSelectedListener
import android.widget.ArrayAdapter
import android.widget.Spinner
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity


class ex7 : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_ex7)
        val lang = arrayOf("c", "c++", "c#", "java", "js", "kotlin", "python", "another one")
        val spinner: Spinner = findViewById<Spinner>(R.id.spinner)
        // Создаем адаптер ArrayAdapter с помощью массива строк и стандартной разметки элемета spinner
        val adapter: ArrayAdapter<String> = ArrayAdapter<String>(this, android.R.layout.simple_spinner_item, lang)
        // Определяем разметку для использования при выборе элемента
        adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item)
        // Применяем адаптер к элементу spinner
        spinner.adapter = adapter

        spinner.setOnItemSelectedListener(object : OnItemSelectedListener {
            override fun onItemSelected(parent: AdapterView<*>, view: View,
                                        position: Int, id: Long) {
                val item: String = parent.getItemAtPosition(position) as String
                Toast.makeText(view.context, "Your favourite programming language = $item", Toast.LENGTH_LONG).show()
                Log.d("Programming language", "Your favourite programming language = $item")

            }

            override fun onNothingSelected(arg0: AdapterView<*>?) {
                Log.d("Programming language", "Nothing has been chosen")
            }
        })

    }

}
