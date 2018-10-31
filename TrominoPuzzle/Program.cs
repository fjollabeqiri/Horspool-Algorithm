using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrominoPuzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            //treminos i paraqesim me karaktere
            //board-in me matrice (me elemente karaktere dmth)

            //hyrje eshte nje matrice
            char[,] board = new char[,] { 
                {'0','_', '0', '0' },
                {'0','0', '0', '0' }, //0-te kemi me i mbushe me nje ngjyre
                {'0','0', '0', '0' },
                {'0','0', '0', '0' }
            };
            //per matricat me te medha se 2x2 duhet me bo ndarje
            //me kriju nje funksion qe kur ja jep matricen psh 4x4, t'i kthen kater 2x2 matrica

            TrominoSolver(board);

            for(int i=0; i < board.GetLength(0); i++)
            {
                for(int j=0; j<board.GetLength(1); j++)
                {
                    Console.Write(board[i, j].ToString() + " ");
                }
                Console.Write("\n"); 
            }

        }
        
        static void Print(char[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j].ToString() + " ");
                }
                Console.Write("\n");
            }
        }

        static int fill=1;
        //Kete funksion e thrrasim kur dojme me e bo zgjidhjen
        static void TrominoSolver(char[,] board)
        {
            if(board.GetLength(0) == 2)
            {
                //tiles qe kane vleren 0 mbushi me ngjyre
                //kompleksiteti konstant eshte per keto dy for loops (O(2))
                for (int i = 0; i < board.GetLength(0); i++) //ose i<2
                {
                    for (int j = 0; j < board.GetLength(1); j++)
                    {
                        if(board[i,j]=='0')
                        {
                            board[i, j] = Char.Parse(fill.ToString());
                        }
                    }
                    fill++;
                }
            }
            int halfBoardLength = board.GetLength(0) / 2;

            char[,] topLeftBoard = GetBoardPart(board, 0, 0, halfBoardLength);
            char[,] topRightBoard = GetBoardPart(board, 0, halfBoardLength, halfBoardLength);
            char[,] bottomLeftBoard = GetBoardPart(board, halfBoardLength, 0, halfBoardLength);
            char[,] bottomRightBoard = GetBoardPart(board, halfBoardLength, halfBoardLength, halfBoardLength);
            //duhet ni funksion qe e kontrollon a duhet ne secilen pjese me vendose T

            if(CheckIfTileNeeded(topLeftBoard))
            {
                topLeftBoard[halfBoardLength - 1, halfBoardLength - 1] = 'T';
            }

            if (CheckIfTileNeeded(topRightBoard))
            {
                topRightBoard[halfBoardLength - 1, 0] = 'T';
            }

            if (CheckIfTileNeeded(bottomLeftBoard))
            {
                bottomLeftBoard[0, halfBoardLength - 1] = 'T';
            }

            if (CheckIfTileNeeded(bottomRightBoard))
            {
                bottomRightBoard[0, 0] = 'T';
            }

            TrominoSolver(topLeftBoard);


            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (i < halfBoardLength && j < halfBoardLength)
                    {
                        board[i, j] = topLeftBoard[i, j];
                    }
                    else if (i >= halfBoardLength && j <= halfBoardLength)
                    {
                        board[i, j] = topLeftBoard[halfBoardLength - i, j];
                    }
                }
                Console.Write("\n");
            }

            Print(board);

            return; //board eshte tip me reference edhe bon me e ekzekutu tash i ndrrohen vlerat
        }

       //Funksion qe kthen particionet qe deshirojme nga nje matrice me e madhe se 2x2
       //P.sh nese matrica eshte 4x4, athere e thrrasim 4 here kete funksion edhe i marrim 4 pjeset qe na duhen
       static char[,] GetBoardPart(char[,] board, int i, int j, int length)
        {
            char[,] resBoard = new char[,] { };
            for (int r = i; r < i + length; r++)
            {
                for(int c=j; c< j + length; c++)
                {
                    resBoard[r - i, c - j] = board[r, c];
                }
            }

            return resBoard;
        }

        static bool CheckIfTileNeeded(char[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == '_' || board[i,j] == 'T')
                    {
                        return false;
                    }
                }
            }
            return true;
        }
       
    }
}
