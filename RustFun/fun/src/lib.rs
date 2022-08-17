
#[no_mangle]
pub extern "C" fn fun_increment(value: i32) -> i32 {
    value + 1
}

#[no_mangle]
pub extern "C" fn fun_decrement(value: i32) -> i32 {
    value - 1
}

#[cfg(test)]
mod tests {

    #[test]
    fn does_increment_work() {
        let result_by_one = crate::fun_increment(0);
        assert_eq!(result_by_one, 1);
    }

    #[test]
    fn does_decrement_work() {
        let result_by_one = crate::fun_decrement(0);
        assert_eq!(result_by_one, -1);
    }

}
