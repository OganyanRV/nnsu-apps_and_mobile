package com.example.oganyanlab4

import android.annotation.SuppressLint
import android.graphics.Color
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.text.Layout
import android.view.*
import android.widget.Button
import android.widget.PopupMenu
import android.widget.TextView
import android.widget.Toast
import androidx.constraintlayout.widget.ConstraintLayout


class ex7 : AppCompatActivity() {
    var begin: Boolean = false
    var begin2: Boolean = false
    var lay: ConstraintLayout ?= null

    @SuppressLint("ClickableViewAccessibility")
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_ex7)

        val up = findViewById<TextView>(R.id.up_border)
        val down = findViewById<TextView>(R.id.down_border)
        val res: TextView = findViewById<TextView>(R.id.res)
        lay = findViewById(R.id.please)

        var y: Float = 0.0F
        var newy: Float = 0.0F
        up.setOnTouchListener(View.OnTouchListener { v: View, event ->
            if (!begin)  {
                y = event.getY()
                newy = y
                begin = true
            }
            if (event.action == MotionEvent.ACTION_DOWN) {
                newy = event.getY()
            } else if (event.action == MotionEvent.ACTION_MOVE) {
                newy = event.getY()
            } else if (event.action == MotionEvent.ACTION_UP) {
                val dify = y - newy
                if (dify <= -20) {
                    res.text = "ВЕРХ"
                    CreateMenu(v);
                }
            }
            true
        })

        down.setOnTouchListener(View.OnTouchListener { v, event ->

            if (!begin2)  {
                y = event.getY()
                newy = y
                begin2 = true
            }
            if (event.action == MotionEvent.ACTION_DOWN) {
                newy = event.getY()
            } else if (event.action == MotionEvent.ACTION_MOVE) {
                newy = event.getY()
            } else if (event.action == MotionEvent.ACTION_UP) {
                val dify = y - newy
                if (dify >= 20) {
                    res.text = "НИЗ"
                    CreateMenu(v);
                }
            }
            true
        });
    };

    fun CreateMenu(view: View)
    {
        val popup:PopupMenu = PopupMenu(this, view);
        popup.setOnMenuItemClickListener { item: MenuItem? ->
            if (item != null) {
                findViewById<TextView>(R.id.res).text = item.title
            };
            true;
        };
        val inflater = popup.menuInflater;
        inflater.inflate(R.menu.popupmenu, popup.menu);
        popup.show();
    }

}