## Sentinel Linear Search
Sentinel Linear Search là một thuật toán tìm kiếm tuyến tính được sử dụng để tìm kiếm một phần tử cụ thể trong một mảng đã sắp xếp hoặc chưa sắp xếp.

Trong thuật toán này, ta thêm một phần tử được gọi là "sentinel" (giám sát viên) vào cuối mảng, có giá trị bằng với giá trị cần tìm kiếm. Sau đó, ta sử dụng một vòng lặp để duyệt qua từng phần tử của mảng, khi gặp phần tử cần tìm kiếm, ta sẽ dừng thuật toán. Với cách làm này, ta không cần phải kiểm tra điều kiện đến khi ta đến phần tử cuối cùng của mảng.

Tuy nhiên, Sentinel Linear Search chỉ hiệu quả khi ta tìm kiếm trong các mảng kích thước nhỏ hoặc các mảng không được sắp xếp. Với các mảng lớn và được sắp xếp, thuật toán tìm kiếm nhị phân sẽ hiệu quả hơn.
