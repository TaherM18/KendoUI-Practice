export function isValidDate(date) {
    // Check if date is null or undefined
    if (!date) return false;

    // Check if date is an instance of Date and is a valid date
    return date instanceof Date && !isNaN(date.getTime());
}
