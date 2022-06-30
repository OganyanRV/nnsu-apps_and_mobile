package com.example.oganyanlab4

import android.os.Parcel
import android.os.Parcelable
import java.util.*

class Note(var description: String?, var date: Date): Parcelable {
    constructor(parcel: Parcel) : this(
        parcel.readString(),
        Date(parcel.readLong())
    )

    override fun writeToParcel(parcel: Parcel, flags: Int) {
        parcel.writeString(description);
        parcel.writeLong(date.time);
    }

    override fun describeContents(): Int {
        return 0
    }

    companion object CREATOR : Parcelable.Creator<Note> {
        override fun createFromParcel(parcel: Parcel): Note {
            return Note(parcel)
        }

        override fun newArray(size: Int): Array<Note?> {
            return arrayOfNulls(size)
        }
    }


}
