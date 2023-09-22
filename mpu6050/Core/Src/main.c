/* USER CODE BEGIN Header */
/**
  ******************************************************************************
  * @file           : main.c
  * @brief          : Main program body
  ******************************************************************************
  * @attention
  *
  * <h2><center>&copy; Copyright (c) 2023 STMicroelectronics.
  * All rights reserved.</center></h2>
  *
  * This software component is licensed by ST under BSD 3-Clause license,
  * the "License"; You may not use this file except in compliance with the
  * License. You may obtain a copy of the License at:
  *                        opensource.org/licenses/BSD-3-Clause
  *
  ******************************************************************************
  */
/* USER CODE END Header */
/* Includes ------------------------------------------------------------------*/
#include "main.h"
#include "i2c.h"
#include "tim.h"
#include "usart.h"
#include "gpio.h"

/* Private includes ----------------------------------------------------------*/
/* USER CODE BEGIN Includes */
#include <stdio.h>
#include <mpu6050.h>
#include <string.h>
/* USER CODE END Includes */

/* Private typedef -----------------------------------------------------------*/
/* USER CODE BEGIN PTD */

/* USER CODE END PTD */

/* Private define ------------------------------------------------------------*/
/* USER CODE BEGIN PD */
/* USER CODE END PD */

/* Private macro -------------------------------------------------------------*/
/* USER CODE BEGIN PM */
#define FRAME  "\n%s%06d %s%06d %s%06d \r"    //"\n%s%06d"!="\n"
#define SIGN(X) ((X)>=0)?" ":"-"
#define ABS(X) ((X)>=0)?((X)):(-(X))
/* USER CODE END PM */

/* Private variables ---------------------------------------------------------*/

/* USER CODE BEGIN PV */
	MPU6050_t MPU6050;
	uint32_t time_example 	= 10; // 10ms
	uint32_t time_current 	= 0;

	char data[50];

//	char str_data[11];
//	char str_title[50] 		="\nRoll_x  Pitch_y";
//
//	char frame [26];





/* USER CODE END PV */

/* Private function prototypes -----------------------------------------------*/
void SystemClock_Config(void);
/* USER CODE BEGIN PFP */

void convert_double_to_string (double value, char *str_data); //fomat double {ttt-xx.xxxx}
char convert_int_to_char (int int_value);
void creat_frame (double roll, double pitch, double yaw, char *frame);
// |\n|+/_|123456| |+/-|123456| |+/-|123456| |\r| ==> 26 byte
void clear_frame (char *frame);



/* USER CODE END PFP */

/* Private user code ---------------------------------------------------------*/
/* USER CODE BEGIN 0 */
//HAL_I2C_IsDeviceReady(hi2c, 0x68, 1,100);


/* USER CODE END 0 */

/**
  * @brief  The application entry point.
  * @retval int
  */
int main(void)
{
  /* USER CODE BEGIN 1 */

  /* USER CODE END 1 */

  /* MCU Configuration--------------------------------------------------------*/

  /* Reset of all peripherals, Initializes the Flash interface and the Systick. */
  HAL_Init();

  /* USER CODE BEGIN Init */

  /* USER CODE END Init */

  /* Configure the system clock */
  SystemClock_Config();

  /* USER CODE BEGIN SysInit */

  /* USER CODE END SysInit */

  /* Initialize all configured peripherals */
  MX_GPIO_Init();
  MX_I2C1_Init();
  MX_USART1_UART_Init();
  MX_TIM2_Init();
  /* USER CODE BEGIN 2 */
//  HAL_TIM_Base_Start_IT(&htim2);
//  char a[10]= "\n";
//  HAL_UART_Transmit(&huart1, &str_title, strlen(str_title)-2, 500);
//  HAL_UART_Transmit(&huart1, &a, strlen(a), 500);
  while (MPU6050_Init(&hi2c1) == 1);
  /* USER CODE END 2 */

  /* Infinite loop */
  /* USER CODE BEGIN WHILE */
  while (1)
  {
    /* USER CODE END WHILE */

    /* USER CODE BEGIN 3 */
	  if (HAL_GetTick()-time_current >= time_example)
	  {
		  time_current = HAL_GetTick();
		  MPU6050_Read_All(&hi2c1,&MPU6050);
		  int datax = MPU6050.KalmanAngleX*1000.0;
		  int datay = MPU6050.KalmanAngleY*1000.0;
		  int dataz = 0;

		  sprintf(data,FRAME,SIGN(datax),ABS(datax),SIGN(datay),ABS(datay),SIGN(dataz),ABS(dataz));

		  HAL_UART_Transmit(&huart1,(uint8_t*)data, strlen(data), 5);


//		  clear_frame (&frame);
//		  creat_frame (MPU6050.KalmanAngleX, MPU6050.KalmanAngleY, 0, &frame);
//		  HAL_UART_Transmit(&huart1, &frame, 26, 500);


//		  convert_double_to_string (MPU6050.KalmanAngleX, &str_data);
//		  HAL_UART_Transmit(&huart1, &str_data, strlen(str_data)-2, 500);
//
//		  convert_double_to_string (MPU6050.KalmanAngleY, &str_data);
//		  HAL_UART_Transmit(&huart1, &str_data, strlen(str_data)-2, 500);
//
//		  HAL_UART_Transmit(&huart1, &a, strlen(a), 500);




	  }


  }
  /* USER CODE END 3 */
}

/**
  * @brief System Clock Configuration
  * @retval None
  */
void SystemClock_Config(void)
{
  RCC_OscInitTypeDef RCC_OscInitStruct = {0};
  RCC_ClkInitTypeDef RCC_ClkInitStruct = {0};

  /** Initializes the RCC Oscillators according to the specified parameters
  * in the RCC_OscInitTypeDef structure.
  */
  RCC_OscInitStruct.OscillatorType = RCC_OSCILLATORTYPE_HSE;
  RCC_OscInitStruct.HSEState = RCC_HSE_ON;
  RCC_OscInitStruct.HSEPredivValue = RCC_HSE_PREDIV_DIV1;
  RCC_OscInitStruct.HSIState = RCC_HSI_ON;
  RCC_OscInitStruct.PLL.PLLState = RCC_PLL_ON;
  RCC_OscInitStruct.PLL.PLLSource = RCC_PLLSOURCE_HSE;
  RCC_OscInitStruct.PLL.PLLMUL = RCC_PLL_MUL9;
  if (HAL_RCC_OscConfig(&RCC_OscInitStruct) != HAL_OK)
  {
    Error_Handler();
  }
  /** Initializes the CPU, AHB and APB buses clocks
  */
  RCC_ClkInitStruct.ClockType = RCC_CLOCKTYPE_HCLK|RCC_CLOCKTYPE_SYSCLK
                              |RCC_CLOCKTYPE_PCLK1|RCC_CLOCKTYPE_PCLK2;
  RCC_ClkInitStruct.SYSCLKSource = RCC_SYSCLKSOURCE_PLLCLK;
  RCC_ClkInitStruct.AHBCLKDivider = RCC_SYSCLK_DIV1;
  RCC_ClkInitStruct.APB1CLKDivider = RCC_HCLK_DIV2;
  RCC_ClkInitStruct.APB2CLKDivider = RCC_HCLK_DIV1;

  if (HAL_RCC_ClockConfig(&RCC_ClkInitStruct, FLASH_LATENCY_2) != HAL_OK)
  {
    Error_Handler();
  }
}

/* USER CODE BEGIN 4 */
//void clear_frame (char *frame)
//{
//	for (int i=0; i<26; i++)
//	{
//		frame[i] = '0';
//	}
//}
//void creat_frame (double roll, double pitch, double yaw, char *frame)
//{
//	int x,y,z;
//	int index_x = 8;
//	int index_y = 16;
//	int index_z = 24;
//	int temp;
//
//	frame [0] 	= '\n';
//	frame [25]	= '\r';
//	frame [8]	= ' ';
//	frame [16]	= ' ';
//	frame [24]	= ' ';
//
//
//	roll 	*= 1000;
//	pitch 	*= 1000;
//	yaw		*= 1000;
//
//	x = roll;
//	y = pitch;
//	z = yaw;
//
////	if (roll==0) frame[7] = '0';
////	if (pitch==0) frame[15] = '0';
////	if (yaw==0) frame[23] = '0';
//
//
//	if (x<0)
//	{
//		frame[1] = '-';
//		x *= -1;
//	} else if (x==0) frame[7] = '0';
//	else frame[1] = ' ';
//
//	if (y<0)
//	{
//		frame[9] = '-';
//		y *= -1;
//	} else if (y==0) frame[15] = '0';
//	else frame[9] = ' ';
//
//	if (z<0)
//	{
//		frame[17] = '-';
//		z *= -1;
//	} else if (z==0) frame[23] = '0';
//	else frame[17] = ' ';
//
//	while (x)
//	{
//		index_x --;
//		temp = x%10;
//		frame [index_x] = convert_int_to_char (temp);
//		x /= 10;
//	}
//	while (y)
//		{
//			index_y --;
//			temp = y%10;
//			frame [index_y] = convert_int_to_char (temp);
//			y /= 10;
//		}
//	while (z)
//		{
//			index_z --;
//			temp = z%10;
//			frame [index_z] = convert_int_to_char (temp);
//			z /= 10;
//		}
//}
//void convert_double_to_string (double value, char *str_data)
//{
//	  int whole, decimal;
//	  decimal = value;
//	  whole = (value - decimal)*10000;
//	  if (whole <0)
//	  {
//		  whole *= (-1);
//		  sprintf(str_data," -%5d.%06d",decimal, whole);
//	  }
//	  sprintf(str_data," %5d.%06d",decimal, whole); //Convert to string
//}
//
//char convert_int_to_char (int int_value)
//{
//    switch (int_value)
//    {
//        case 0:
//            return 0x30;
//            break;
//        case 1:
//            return 0x31;
//            break;
//        case 2:
//            return 0x32;
//            break;
//        case 3:
//            return 0x33;
//            break;
//        case 4:
//            return 0x34;
//            break;
//        case 5:
//            return 0x35;
//            break;
//        case 6:
//            return 0x36;
//            break;
//        case 7:
//            return 0x37;
//            break;
//        case 8:
//            return 0x38;
//            break;
//        case 9:
//            return 0x39;
//            break;
//        default:
//            break;
//    }
//}
/* USER CODE END 4 */

/**
  * @brief  This function is executed in case of error occurrence.
  * @retval None
  */
void Error_Handler(void)
{
  /* USER CODE BEGIN Error_Handler_Debug */
  /* User can add his own implementation to report the HAL error return state */
  __disable_irq();
  while (1)
  {
  }
  /* USER CODE END Error_Handler_Debug */
}

#ifdef  USE_FULL_ASSERT
/**
  * @brief  Reports the name of the source file and the source line number
  *         where the assert_param error has occurred.
  * @param  file: pointer to the source file name
  * @param  line: assert_param error line source number
  * @retval None
  */
void assert_failed(uint8_t *file, uint32_t line)
{
  /* USER CODE BEGIN 6 */
  /* User can add his own implementation to report the file name and line number,
     ex: printf("Wrong parameters value: file %s on line %d\r\n", file, line) */
  /* USER CODE END 6 */
}
#endif /* USE_FULL_ASSERT */

/************************ (C) COPYRIGHT STMicroelectronics *****END OF FILE****/
