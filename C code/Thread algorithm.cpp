#include <stdio.h>
#include <pthread.h>
#include <unistd.h>
#define LOOT_WORKER 10 //Loot per worker
#define MAX_RESS 2000 //MAX ressources on the map

int curRess = 0; // Current ressources 
int NUM_THREADS = 1; //Number of Threads
int exitGame = 0; //flag for exit 
pthread_mutex_t curRess_mutex; //locker for ressources 

void *busy_work(void *data)
{
    int i;
    size_t thread_num = (size_t)data; //num of threads    
    	while(1)
			{			
				if(exitGame == 1)
				{					
					pthread_exit(NULL);	
					return 0;
				}	
				if(curRess >= MAX_RESS) //Validate if ressources finished
				{
				    exitGame == 1;	
					return 0;
				}
					printf("Worker %zd is searching\n", thread_num);
					printf("Worker %zd is transporting\n", thread_num);
					//usleep(90000);
					pthread_mutex_lock(&curRess_mutex);
					curRess += LOOT_WORKER;				
					//sleep(1);
					printf("Worker %zd unloaded resources to Base station\n", thread_num);
					pthread_mutex_unlock(&curRess_mutex);	
			} 
    pthread_exit(NULL);
}

//--------------------------------------------
// FUNCTION: main
// The main function where i create and join threads and print final result
//--------------------------------------------
int main()
{
    size_t i;
    pthread_t threads[NUM_THREADS];
    pthread_mutex_init(&curRess_mutex, NULL);
	    for (i = 0; i < NUM_THREADS; i++) {
	        int error = pthread_create(&threads[i], NULL, busy_work,(void*)i);
	        if (error != 0) {
	            fprintf(stderr, "Error creating thread %zd: error: %d\n", i, error);
	        }
	    }
	    for (i = 0; i < NUM_THREADS; i++) {
	        int error = pthread_join(threads[i], NULL);
	        if (error != 0) {
	            fprintf(stderr, "Error joining thread %zd: error: %d\n", i, error);
	        }
	    }	
		pthread_mutex_destroy(&curRess_mutex);
	    return 0;
}

