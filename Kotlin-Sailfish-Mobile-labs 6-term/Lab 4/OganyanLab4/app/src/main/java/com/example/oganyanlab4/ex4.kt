package com.example.oganyanlab4

import android.app.AlertDialog
import android.content.Intent
import android.icu.util.Calendar
import android.os.Build
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.widget.CalendarView
import android.widget.EditText
import androidx.annotation.RequiresApi
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.RecyclerView
import java.util.*
import kotlin.Comparator
import kotlin.collections.ArrayList

class ex4 : AppCompatActivity() {
    private lateinit var date: Date;
    private var dateSelected = false;
    private lateinit var rv: RecyclerView;
    private var notes: ArrayList<Note> = ArrayList();

    @RequiresApi(Build.VERSION_CODES.N)
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_ex4)
        date = Calendar.getInstance().time;
        RecycleViewcreate();
    }

    private fun RecycleViewcreate() {
        rv = findViewById(R.id.list_notes);
        rv.layoutManager = LinearLayoutManager(this);

        notes.sortWith(Comparator { lhs: Note, rhs: Note ->
            if (lhs.date < rhs.date)
                return@Comparator -1;
            else if (lhs.date > rhs.date)
                return@Comparator 1;
            else
                return@Comparator 0;
        });
        val adapter: NoteAdapter = NoteAdapter(this, notes);
        rv.adapter = adapter;
    }


    @RequiresApi(Build.VERSION_CODES.N)
    fun AddNote(view: View) {
        val infl = LayoutInflater.from(applicationContext).inflate(
            R.layout.dialog_note,
            null
        );
        val alertDialogBuilder = AlertDialog.Builder(this);
        val calendar = Calendar.getInstance();
        val calendarView = infl.findViewById<CalendarView>(R.id.calendar_note);
        calendarView.setOnDateChangeListener { view, year, month, day ->
            dateSelected = true;
            calendar.set(year, month, day);
            date = calendar.time;
        }
        alertDialogBuilder.setView(infl);

        alertDialogBuilder.setCancelable(true)
            .setPositiveButton(
                "Ok"
            ) { dialog, whichButton ->
                val description_cur = infl.findViewById<EditText>(R.id.text_note).text.toString();
                val date_cur: Date;
                if (dateSelected) date_cur = date else date_cur = Date(calendarView.date)


                notes.add(Note(description_cur, date_cur));

                notes.sortWith(Comparator { lhs: Note, rhs: Note ->
                    if (lhs.date < rhs.date)
                        return@Comparator -1;
                    else if (lhs.date > rhs.date)
                        return@Comparator 1;
                    else
                        return@Comparator 0;
                });

                val adapter = NoteAdapter(this, notes);
                rv.adapter = adapter;
                dateSelected = false;
            }
            .setNegativeButton(
                "Cancel"
            ) { dialog, whichButton -> dialog.cancel() };
        alertDialogBuilder.create().show();
    }

    fun SaveProgress(view: View) {
        val newAct = Intent(this, ex6::class.java);
        newAct.putExtra("data", notes);
        startActivity(newAct);
    }

}