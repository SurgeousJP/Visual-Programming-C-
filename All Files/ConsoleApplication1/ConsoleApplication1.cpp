

#include <iostream>
using namespace std;

struct KhachHang {
    char MaKH[30];
    char TenKH[30];
    int KV;
    int soKgDien;
};

void NhapDSKhachHang(KhachHang list[], int &n) {
    cout << "Hay nhap so khach hang: ";
    int n;
    cin >> n;
    for (int i = 0; i < n; i++) {
        cout << "Hay nhap khu vuc: ";
        cin >> list[i].KV;
        while (list[i].KV < 1 || list[i].KV > 3) {
            cout << "Khu vuc da nhap khong hop le, vui long nhap lai: ";
            cin >> list[i].KV;
        }
        cout << "Hay nhap ma khach hang: ";
        cin >> list[i].MaKH;
        cout << "Hay nhap ten khach hang:\n";
        cin.getline(list[i].TenKH, 1000);
        cout << "Hay nhap soKgDien: ";
        cin >> list[i].soKgDien;
    }
}
void XuatDSKhachHang(KhachHang list[], int n) {
    for (int i = 0; i < n; i++) {
        cout << "Ma khach hang: " << list[i].MaKH << "\n";
        cout << "Ten khach hang: " << list[i].TenKH << "\n";
        cout << "Khu vuc: " << list[i].KV << "\n";
        cout << "So KgDien: " << list[i].soKgDien << "\n\n";
    }
}
int MaxKgDien(KhachHang list[], int n) {
    int maxKgDien = list[0].KV * 1000 * list[0].soKgDien;
    for (int i = 1; i < n; i++) {
        if (maxKgDien < list[i].KV * 1000 * list[i].soKgDien) {
            maxKgDien = list[i].KV * 1000 * list[i].soKgDien;
        }
    }
}
void XuatDSMaxKgDien(KhachHang list[], int n) {
    int maxKgDien = MaxKgDien(list, n);
    for (int i = 0; i < n; i++) {
        if (list[i].KV * 1000 * list[i].soKgDien == maxKgDien) {
            cout << "Ma khach hang: " << list[i].MaKH << "\n";
            cout << "Ten khach hang: " << list[i].TenKH << "\n";
            cout << "Khu vuc: " << list[i].KV << "\n";
            cout << "So KgDien: " << list[i].soKgDien << "\n\n";
        }
    }
}
int CountKHKhuVuc1(KhachHang list[], int n, int i) {
    if (i == n) {
        return 0;
    }
    else {
        if (list[i].KV == 1) {
            return 1 + CountKHKhuVuc1(list, n, i + 1);
        }
        else return CountKHKhuVuc1(list, n, i + 1);
    }
}
void SortDescKV(KhachHang list[], int n) {
    for (int i = 0; i < n; i++) {
        for (int j = i + 1; j < n; j++) {
            if (list[i].KV < list[j].KV) {
                KhachHang temp;
                temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }
        }
    }
}
int main()
{
    int n;
    KhachHang list[1000];
    NhapDSKhachHang(list, n);
    cout << "DS cac khach hang:\n";
    XuatDSKhachHang(list, n);
    cout << "\n";
    cout << "DS cac khach hang co tien phai tra nhieu nhat:\n";
    XuatDSMaxKgDien(list, n);
    cout << ""
}

