package com.example.oganyanlab4

import android.graphics.Color
import android.os.Bundle
import android.view.ContextMenu
import android.view.MenuItem
import android.view.View
import android.widget.ArrayAdapter
import android.widget.ListView
import android.widget.TextView
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import org.w3c.dom.Text

class ex8 : AppCompatActivity() {
    var countries =
        arrayOf(
            "Россия",
            "Украина",
            "Бразилия",
            "Англия",
            "Аргентина",
            "Германия",
            "Канада",
            "Мексика",
            "Америка",
            "Франция",
            "Германия"
        )

    var txt: TextView ?= null
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_ex8)
        // получаем элемент ListView
        val countriesList: ListView = findViewById(R.id.countriesList) as ListView;
        txt = findViewById<TextView>(R.id.choice)
        // создаем адаптер
        val adapter: ArrayAdapter<String> = ArrayAdapter(
            this,
            android.R.layout.simple_list_item_1, countries
        );

        // устанавливаем для списка адаптер
        countriesList.setAdapter(adapter);

//        for (i in 0..countries.size) {
//            registerForContextMenu(countries[i])
//        }
        registerForContextMenu(countriesList)
    }

    override fun onCreateContextMenu(
        menu: ContextMenu?,
        v: View?,
        menuInfo: ContextMenu.ContextMenuInfo?
    ) {
        if (menu != null) {
            menu.add(0, 0, 0, "Great!")
            menu.add(0, 1, 0, "Fine :/")
            menu.add(0, 2, 0, "Bruh :c")
        }
        // super.onCreateContextMenu(menu, v, menuInfo)
    }

    override fun onContextItemSelected(item: MenuItem): Boolean {
        when(item.itemId) {
            0 -> {
                txt!!.text = ("Great!").toString()
                txt!!.setTextColor(Color.GREEN)
                Toast.makeText(
                    applicationContext,
                    "Chosen Great!",
                    Toast.LENGTH_SHORT
                ).show();
            }
            1 -> {
                txt!!.text = ("Fine :/").toString()
                txt!!.setTextColor(Color.YELLOW)
                Toast.makeText(
                    applicationContext,
                    "Chosen Fine :/",
                    Toast.LENGTH_SHORT
                ).show();
            }
            2 -> {
                txt!!.text = ("Bruh :c").toString()
                txt!!.setTextColor(Color.RED)
                Toast.makeText(
                    applicationContext,
                    "Chosen Bruh :c",
                    Toast.LENGTH_SHORT
                ).show();
            }
        }
        return super.onContextItemSelected(item)
    }
}