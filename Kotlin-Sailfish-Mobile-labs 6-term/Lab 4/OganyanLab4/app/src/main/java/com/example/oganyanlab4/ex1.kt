package com.example.oganyanlab4


import android.annotation.SuppressLint
import android.app.ActivityManager
import android.content.Intent
import android.os.Bundle
import android.view.View
import android.widget.TextView
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import androidx.core.content.ContextCompat
import androidx.core.content.IntentCompat
import android.app.ActivityManager.AppTask
import android.os.Build
import androidx.annotation.RequiresApi


class ex1 : AppCompatActivity() {
    private lateinit var am: ActivityManager;

    @SuppressLint("SetTextI18n")
    @RequiresApi(Build.VERSION_CODES.M)
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_ex1)

        am = getSystemService(ACTIVITY_SERVICE) as ActivityManager
        val task: ActivityManager.AppTask = am.appTasks[0]
//        val kek = am.appTasks
//        val kek2 = kek[0].taskInfo
        findViewById<TextView>(R.id.stack).text =
            ("Длина Стэка: ").toString() + ((task.taskInfo.numActivities) - 1).toString()

    }


//    fun Clear(view: View)
//    {
//        val intentToBeNewRoot = Intent(this, MainActivity::class.java)
//        val cn = intentToBeNewRoot.component
//        val mainIntent: Intent = Intent.makeRestartActivityTask(cn)
//        startActivity(mainIntent)
//    }

    @RequiresApi(Build.VERSION_CODES.M)
    fun Pop(view: View) {
//        val kek = am.appTasks
//        val kek2 = kek[0].taskInfo
        if ((am.appTasks[0].taskInfo.numActivities) != 2)
            this.finish();
        else
            Toast.makeText(
                applicationContext,
                "It's the last activity in the stack",
                Toast.LENGTH_SHORT
            ).show();
    }

    @RequiresApi(Build.VERSION_CODES.M)
    fun Push(vied: View) {
        val newActivity: Intent = Intent(this, ex1::class.java);
//       val kek = am.appTasks
//     val kek2 = kek[0].taskInfo
        startActivity(newActivity);
    }
    @RequiresApi(Build.VERSION_CODES.M)
    fun exit(view: View) {
        val intentToBeNewRoot = Intent(this, MainActivity::class.java)
        val cn = intentToBeNewRoot.component
        val mainIntent: Intent = Intent.makeRestartActivityTask(cn)
        startActivity(mainIntent)

//        val kek = am.appTasks
//        val kek2 = kek[0].taskInfo

    }
}