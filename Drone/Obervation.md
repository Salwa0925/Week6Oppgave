# Using Thread + Join
* When running two drones with **Threads**, the program prints output in a random order.

* Initially, the terminal printed everything unpredictably, but by adding **Thread.Join()**, the two drones’ outputs were separated.

* Before adding **Thread.Sleep()**, all output appeared at once; after adding it, the output prints according to the assigned delay in milliseconds.

* The message indicating a successful landing appears at the end of the output.

# Using Task + TaskCompletionSource (TCS)

* Output is still somewhat random, and separating logs for each drone can be tricky.


# Using FlyTwoDronesWithAsync (async/await)

* When running two drones using **async/await**, the output is essentially the same as with **TCS**.

* The main and most important difference is that writing code with **async/await** takes less time compared to **TCS**.

* At the same time, it is less confusing because the built-in **await** functionality makes the flow smoother.


