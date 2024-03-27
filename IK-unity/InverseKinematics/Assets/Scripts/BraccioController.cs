using UnityEngine;
using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.Threading;

public class BraccioController : MonoBehaviour
{

    private SerialPort serialPort;
    private string portName = "/dev/cu.usbmodem142401";
    private int baudRate = 115200;
    private Queue<string> messageQueue;  // Thread-safe queue for messages
    private Thread serialThread;
    private SerialController sc;

    void Start()
    {
        sc = GetComponent<SerialController>();
        //serialPort = new SerialPort(portName, baudRate);
        //messageQueue = new Queue<string>(); // Initialize message queue
        //serialThread = new Thread(WriteToSerial); // Create thread for writing
        //serialThread.Start();
        //serialPort.WriteTimeout = 100;

        //try
        //{
        //    serialPort.Open();
        //    Debug.Log("Serial port opened successfully on: " + portName);
        //}
        //catch (System.Exception e)
        //{
        //    Debug.LogError("Error opening serial port: " + e.Message);
        //}
    }

    public void SendSerialMessage(string message)  // Public function to add messages
    {
        sc.SendSerialMessage(message);
        //messageQueue.Enqueue(message);
        //messageAvailableEvent.Set();  // Signal the event when a message is added
    }

    //private void WriteToSerial()
    //{
    //    while (true)
    //    {
    //        //messageAvailableEvent.WaitOne(1000);  // Wait on the event
            
    //        lock (messageQueue)  // Lock queue for thread safety
    //        {
    //            if (messageQueue.Count > 0)
    //            {
                    
    //                string message = messageQueue.Dequeue();
    //                Debug.Log(message);
    //                serialPort.WriteLine(message);
                    
    //            }
    //        }
            
    //        Thread.Sleep(1000);
    //    }
    //}

    //void OnDisable()
    //{
    //    if (serialPort != null && serialPort.IsOpen)
    //    {
    //        serialPort.Close();
    //    }
    //}

}

