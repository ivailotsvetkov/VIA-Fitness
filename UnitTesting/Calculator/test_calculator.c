#include "minunit.h"
#include <stdio.h>

#define TEST
#ifdef TEST



int tests_run = 0;

static char * testZeroPlusZero() {
	mu_assert("0+0=0", add(0, 0) == 0);

}
static char * all_tests() {
	mu_run_test(testZeroPlusZero);
	return 0;
}

int main(int argc, char **argv) {
	char *result = all_tests();
	if (result != 0) {
		printf("%s\n", result);
	}
	else {
		printf("ALL TESTS PASSED\n");
	}
	printf("Tests run: %d\n", tests_run);
	while (1);
	return result != 0;
}
#endif // TEST