// See https://aka.ms/new-console-template for more information

void quickSort(int[] array) {
    quickSortRecursive(array, 0, array.Length - 1);
}

void quickSortRecursive(int[] array, int leftBorder, int rightBorder) {
    int leftMarker = leftBorder;
    int rightMarker = rightBorder;
    int pivot = array[(leftMarker + rightMarker) / 2];
    do {
        while (array[leftMarker] < pivot)
        leftMarker++;
        while (array[rightMarker] > pivot)
        rightMarker--;
        if (leftMarker <= rightMarker) {
            if (leftMarker < rightMarker) {
                int temp = array[leftMarker];
                array[leftMarker] = array[rightMarker];
                array[rightMarker] = temp;
            }
        leftMarker++;
        rightMarker--;
        }
    } while (leftMarker <= rightMarker);
    if (leftMarker < rightBorder)
        quickSortRecursive(array, leftMarker, rightBorder);
    if (leftBorder < rightMarker)
        quickSortRecursive(array, leftBorder, rightMarker);
    }

int[] array = new int[10] {6,2,7,8,2,2,1,9,0,2};
quickSort(array);
for(int i=0; i<array.Length; i++) {
    Console.Write(array[i]);
}