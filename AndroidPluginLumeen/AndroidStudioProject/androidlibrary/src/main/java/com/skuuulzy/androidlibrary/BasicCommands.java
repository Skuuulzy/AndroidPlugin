package com.skuuulzy.androidlibrary;

import android.app.Application;
import android.content.Context;
import android.widget.Toast;
import android.os.Vibrator;

public class BasicCommands extends Application
{
    
    //Display a simple short toast in a given context
    public void ShowToast(final Context context, final String toastMessage )
    {
        Toast toast = Toast.makeText(context, toastMessage, Toast.LENGTH_SHORT);
        toast.show();
    }

    public void Vibrate(Vibrator vib, long vibrationTime)
    {
        // Vibrate for a given time
        vib.vibrate(vibrationTime);
    }
}