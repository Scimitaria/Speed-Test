program sort
    implicit none
    integer :: arr(100) = (/ 23, 69, 72, 41, 55, 6, 57, 3, 65, 37, 4, 48, 74, 27, 18, 9, 51, 76, 66,100, 33, 87, 68, 42, 10, 35, 34, 8, 12, 31, 88, 52, 98, 99, 90, 5, 73, 21, 89, 81, 36, 2, 1, 47, 54, 24, 59, 30, 16, 13, 70, 19, 67, 94, 60, 43, 45, 25, 95, 26, 44, 49, 46, 96, 56, 7, 93, 20, 82, 97, 62, 39, 78, 86, 71, 58, 63, 14, 28, 29, 64, 79, 32, 77, 50, 75, 91, 22, 61, 53, 15, 83, 85, 84, 80, 11, 17, 92, 38, 40 /)
    integer :: ret(100), i, j

    do concurrent (j = 1:100)
        ret(rank(arr(j))) = arr(j)
    end do

contains
    pure integer function rank(e) result(r)
        implicit none
        integer, intent(in) :: e
        integer :: i

        r = 1
        do i = 1, size(arr)
            if (arr(i) < e) then
                r = r + 1
            end if
        end do
    end function rank
end program sort