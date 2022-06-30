package com.example.oganyanlab4

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import androidx.viewpager.widget.ViewPager

class ex6 : AppCompatActivity() {
    lateinit var note: ArrayList<Note>;
    lateinit var viewPager: ViewPager;
    lateinit var vAdapter: ViewPagerAdapter;


    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_ex6)

        note = intent.getSerializableExtra("data") as ArrayList<Note>;
        viewPager = findViewById(R.id.view);
        vAdapter = ViewPagerAdapter(this, note);
        viewPager.adapter = vAdapter;
    }
}