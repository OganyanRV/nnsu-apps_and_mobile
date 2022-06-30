package com.example.oganyanlab4

import android.content.Context
import android.icu.text.SimpleDateFormat
import android.os.Build
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.ImageView
import android.widget.TextView
import androidx.annotation.RequiresApi
import androidx.cardview.widget.CardView
import androidx.recyclerview.widget.RecyclerView
import java.util.*
import kotlin.collections.ArrayList


class NoteAdapter internal constructor(
    context: Context,
    note: List<Note>
) :
    RecyclerView.Adapter<NoteAdapter.ViewHolder>() {
    class ViewHolder internal constructor(view: View) : RecyclerView.ViewHolder(view) {
        val descriptionView: TextView
        val dateView: TextView

        init {
            descriptionView = view.findViewById<View>(R.id.description_ln) as TextView
            dateView = view.findViewById<View>(R.id.date_ln) as TextView
        }
    }

    private var note: List<Note> = note;

    override fun onCreateViewHolder(
        parent: ViewGroup,
        viewType: Int
    ): ViewHolder {
        val view: View =
            LayoutInflater.from(parent.context).inflate(R.layout.list_note, parent, false)
        return ViewHolder(view)
    }

    @RequiresApi(Build.VERSION_CODES.N)
    override fun onBindViewHolder(
        holder: ViewHolder,
        position: Int
    ) {
        val sdfDate = SimpleDateFormat("d MMMM yyyy", Locale.getDefault());
        val note_cur: Note = note[position]
        holder.descriptionView.setText(note_cur.description)
        holder.dateView.setText(sdfDate.format(note_cur.date))
    }

    override fun getItemCount(): Int {
        return note.size
    }

}