using System;
using DataStructures;
using System.Windows.Forms;

namespace Task2
{
    // Сортировщик
    public class Sorter
    {
        public static int SwapsCount;
        public static int ComparsionsCount;

        public static Control DemonstrationControl = null;

        public static void BubbleSort(int[] arr, int left, int right)
        {
            SwapsCount = 0;
            ComparsionsCount = 0;

            for (int i = left; i <= right; i++)
                for (int j = right; j > i; j--)
                    if (Compare(arr, j, j - 1) == -1)
                        Swap(arr, j, j - 1);
        }

        public static void TwoWaysInsertionSort(int[] arr, int left, int right)
        {
            SwapsCount = 0;
            ComparsionsCount = 0;

            int[] arrPart = new int[right - left + 1];
            for (int i = left; i <= right; i++)
                arrPart[i - left] = arr[i];

            int size = arrPart.Length;
            int leftIndex = size - 1;
            int rightIndex = size - 1;

            int[] tempArr = new int[size * 2 - 1];

            Move(tempArr, size - 1, arrPart[0]);

            for (int i = 1; i < size; i++)
            {
                int t = arrPart[i];

                if (t >= arrPart[0])
                {
                    int j;
                    for (j = rightIndex; j >= 0 && CompareOne(tempArr, t, j) == -1; j--)
                        Move(tempArr, j + 1, tempArr[j]);

                    Move(tempArr, j + 1, t);

                    rightIndex++;
                }
                else
                {
                    int j;
                    for (j = leftIndex; j <= 2 * size - 1 && CompareOne(tempArr, t, j) == 1; j++)
                        Move(tempArr, j - 1, tempArr[j]);

                    Move(tempArr, j - 1, t);
                    leftIndex--;

                }
            }

            for (int j = leftIndex; j < leftIndex + size; j++)
                arrPart[j - leftIndex] = tempArr[j];

            for (int i = 0; i < arrPart.Length; i++)
                arr[i + left] = arrPart[i];
        }
        
        public static void TwoWaysListInsertionSort(ref DoubleLinkedList list)
        {
            SwapsCount = 0;
            ComparsionsCount = 0;

            DoubleLinkedList sortedList = new DoubleLinkedList();

            DoubleLinkedListNode currentNode = list.Head;

            int currentIteration = 0;

            while (currentNode != null)
            {
                DoubleLinkedListNode nextNode = currentNode.Next;
                currentNode.Prev = currentNode.Next = null;

                TwoWaysListInsert(sortedList, new DoubleLinkedListNode(currentNode.Value), currentIteration++);
                currentNode = nextNode;
            }

            list = sortedList;
        }

        public static void TwoWaysListInsert(DoubleLinkedList list, DoubleLinkedListNode node, int iteration)
        {
            ComparsionsCount++;

            if (list.Empty)
            {
                list.Add(node);
                SwapsCount++;
                StepVisualize(list.ToArray(), iteration, -1, false);

            }
            else if (list.Head.Value >= node.Value)
            {
                list.AddToHead(node);
                StepVisualize(list.ToArray(), 0, -1, false);

                SwapsCount++;
            }
            else
            {
                int position = 0;
                DoubleLinkedListNode currentNode = list.Head;

                while (currentNode.Next != null && currentNode.Next.Value < node.Value)
                {
                    ComparsionsCount++;
                    currentNode = currentNode.Next;
                    StepVisualize(list.ToArray(), position, -1, false);
                    position++;
                }

                node.Next = currentNode.Next;

                if (currentNode.Next != null)
                    node.Next.Prev = node;

                list.AddAfter(currentNode, node);
                SwapsCount++;
                StepVisualize(list.ToArray(), position, -1, true);
            }
        }

        public static int Compare(int[] arr, int indexA, int indexB)
        {
            ComparsionsCount++;

            StepVisualize(arr, indexA, indexB);

            return (arr[indexA] == arr[indexB]) ? 0 :
                (arr[indexA] > arr[indexB]) ? 1 : -1;
        }

        public static int CompareOne(int[] arr, int value, int index)
        {
            ComparsionsCount++;

            StepVisualize(arr, index, -1);

            return (value == arr[index]) ? 0 :
                (value > arr[index]) ? 1 : -1;
        }

        public static void Swap(int[] arr, int indexA, int indexB)
        {
            SwapsCount++;
            StepVisualize(arr, indexA, indexB, true);

            int t = arr[indexA];
            arr[indexA] = arr[indexB];
            arr[indexB] = t;

            StepVisualize(arr, indexA, indexB, false);

        }

        public static void Move(int[] arr, int index, int b)
        {
            SwapsCount++;
            StepVisualize(arr, index, -1, true);

            arr[index] = b;

            StepVisualize(arr, index, -1, false);
        }

        private static void StepVisualize(int[] arr, int index1, int index2, bool swap = false)
        {
            if (DemonstrationControl == null || index1 == index2)
                return;

            Demonstrator.VisualizeArray(DemonstrationControl,
                arr, new int[] { index1, index2 },
                (swap) ? Demonstrator.SelectionType.Swap : Demonstrator.SelectionType.Comparsion);

            System.Threading.Thread.Sleep(Demonstrator.DEMOSTRATION_STEP_TIME);
        }
    }
}
