package com.example.oganyanlab4

import android.R
import android.content.Context
import android.icu.text.SimpleDateFormat
import android.os.Build
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.LinearLayout
import android.widget.TextView
import androidx.viewpager.widget.PagerAdapter
import android.widget.ImageView
import androidx.annotation.RequiresApi
import java.util.*


class ViewPagerAdapter(
    context: Context,
    note: List<Note>
) : PagerAdapter() {
    private val mContext: Context
    private var note: List<Note>;
    lateinit var infater: LayoutInflater;
    init {
        mContext = context
        this.note = note
    }

    override fun getCount(): Int {
        return note.size
    }

    override fun isViewFromObject(view: View, `object`: Any): Boolean {
        return view === `object`
    }

    @RequiresApi(Build.VERSION_CODES.N)
    override fun instantiateItem(container: ViewGroup, position: Int): Any {

        val inflater = mContext
            .getSystemService(Context.LAYOUT_INFLATER_SERVICE) as LayoutInflater
        val itemView = inflater.inflate(com.example.oganyanlab4.R.layout.list_note, container, false)
        val sdfDate = SimpleDateFormat("d MMMM yyyy", Locale.getDefault());
        val note_cur: Note = note[position]
        val descriptionTextView =itemView.findViewById<TextView>(com.example.oganyanlab4.R.id.description_ln)
        val dateTextView = itemView.findViewById<TextView>((com.example.oganyanlab4.R.id.date_ln))

      descriptionTextView.text = note_cur.description
        dateTextView.text = sdfDate.format(note_cur.date)
        container.addView(itemView)
        return itemView
    }

    override fun destroyItem(
        container: ViewGroup,
        position: Int,
        `object`: Any
    ) {
        container.removeView(`object` as LinearLayout)
    }


}