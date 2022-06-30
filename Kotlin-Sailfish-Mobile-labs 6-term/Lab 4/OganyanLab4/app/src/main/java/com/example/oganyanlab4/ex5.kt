package com.example.oganyanlab4

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import android.webkit.WebView
import android.webkit.WebViewClient
import android.widget.TextView

class ex5 : AppCompatActivity() {
    private lateinit var webView: WebView;
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_ex5)
        webView = findViewById<WebView>(R.id.webView)
        //webView.loadData()
    }

    fun open(view: View) {
        val txt: String = findViewById<TextView>(R.id.textView).text.toString()
        //webView.loadUrl(txt);
        webView.setWebViewClient(WebViewClient())
        webView.loadUrl(txt);
    }
}